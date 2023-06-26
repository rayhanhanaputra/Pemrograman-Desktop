using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        private string conversationId;  // Conversation ID for maintaining the conversation state
        private string conversationHistory;  // Conversation history
        private string context = "You are OrderBot, an automated service to collect orders for a pizza restaurant.You first greet the customer, then collects the order, and then asks if it's a pickup or delivery. You wait to collect the entire order, then summarize it and check for a final time if the customer wants to add anything else. If it's a delivery, you ask for an address.Finally you collect the payment.Make sure to clarify all options, extras and sizes to uniquely identify the item from the menu.You respond in a short, very conversational friendly style.The menu includes" +
           " pepperoni pizza  12.95, 10.00, 7.00 " +
           " cheese pizza   10.95, 9.25, 6.50 " +
           " eggplant pizza   11.95, 9.75, 6.75 " +
           " fries 4.50, 3.50 " +
           " greek salad 7.25 " +
           " Toppings: " +
           " extra cheese 2.00, " +
           " mushrooms 1.50 " +
           " sausage 3.00 " +
           " canadian bacon 3.50 " +
           " AI sauce 1.50 " +
           " peppers 1.00 " +
           " Drinks: " +
           " coke 3.00, 2.00, 1.00 " +
           " sprite 3.00, 2.00, 1.00 " +
           " bottled water 5.00 ";  // Conversation history
        public Form3()
        {
            InitializeComponent();
            StartConversation();
        }
        private async void StartConversation()
        {
            try
            {
                // API endpoint URL
                string apiUrl = "https://api.openai.com/v1/chat/completions";

                // Create an HTTP client
                using (var httpClient = new HttpClient())
                {
                    // Set the OpenAI API authorization token
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer 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");

                    // API request payload to start the conversation
                    var startRequest = new
                    {
                        model = "gpt-3.5-turbo",
                        messages = new[]
                        {
                            new { role = "system", content = context }
                        }
                    };

                    // Serialize the start request payload to JSON
                    string jsonStartRequest = Newtonsoft.Json.JsonConvert.SerializeObject(startRequest);

                    // Send the POST request to start the conversation
                    var startResponse = await httpClient.PostAsync(apiUrl, new StringContent(jsonStartRequest, System.Text.Encoding.UTF8, "application/json"));

                    // Check if the request was successful
                    if (startResponse.IsSuccessStatusCode)
                    {
                        // Read the response content
                        string jsonStartResponse = await startResponse.Content.ReadAsStringAsync();

                        // Deserialize the JSON response
                        dynamic startResponseData = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonStartResponse);

                        // Extract the conversation ID
                        conversationId = startResponseData.id;
                    }
                    else
                    {
                        // Request failed, handle the error
                        MessageBox.Show("Failed to start the conversation. Error: " + startResponse.StatusCode);
                        MessageBox.Show(await startResponse.Content.ReadAsStringAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                // Exception occurred, handle the error
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private async Task<string> SendMessageToChatGPT(string message)
        {
            try
            {
                // API endpoint URL
                string apiUrl = "https://api.openai.com/v1/chat/completions";

                // Create an HTTP client
                using (var httpClient = new HttpClient())
                {
                    // Set the OpenAI API authorization token
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer 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");

                    // Append the user message to the conversation history
                    conversationHistory += "User: " + message + Environment.NewLine;

                    // Append the conversation history to the messages
                    var messages = new[]
                    {
                        new { role = "system", content = context },
                        new { role = "user", content = message },
                        new { role = "assistant", content = conversationHistory }
                    };

                    // API request payload to send the message
                    var requestBody = new
                    {
                        model = "gpt-3.5-turbo",
                        messages
                    };

                    // Serialize the request payload to JSON
                    string jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);

                    // Send the POST request to the API
                    var response = await httpClient.PostAsync(apiUrl, new StringContent(jsonRequest, System.Text.Encoding.UTF8, "application/json"));

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        // Deserialize the JSON response
                        dynamic responseData = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);

                        // Extract and return the AI response
                        string aiResponse = responseData.choices[0].message.content;

                        // Append the AI response to the conversation history
                        conversationHistory += aiResponse + Environment.NewLine;

                        return aiResponse;
                    }
                    else
                    {
                        // Request failed, handle the error
                        MessageBox.Show("Failed to send the message. Error: " + response.StatusCode);
                        return string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                // Exception occurred, handle the error
                MessageBox.Show("Exception: " + ex.Message);
                return string.Empty;
            }
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageRichTextBox.Text;

            if (!string.IsNullOrEmpty(message))
            {
                // Send the message to ChatGPT
                string response = await SendMessageToChatGPT(message);

                // Append the user message and AI response to the conversation

                conversationRichTextBox.SelectionAlignment = HorizontalAlignment.Right;
                conversationRichTextBox.AppendText(message + Environment.NewLine);
                conversationRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
                conversationRichTextBox.AppendText(response + Environment.NewLine);

                // Clear the message text box
                messageRichTextBox.Clear();
            }
        }
    }
}
