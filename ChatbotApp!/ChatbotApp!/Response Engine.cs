using System;
namespace ChatbotApp_
{
    
    public static class ResponseEngine
    {
        private static readonly Dictionary<string[], string> _responses = new()
    {
        {
            new[] { "how are you", "how are u", "how r you" },
            "I'm fully operational and vigilant! Always on the lookout for cyber threats. How can I help you stay safe today?"
        },
        {
            new[] { "purpose", "what do you do", "what can you do", "why are you here" },
            "My purpose is to help you stay safe online! I can teach you about password safety, phishing scams, safe browsing habits, and much more."
        },
        {
            new[] { "what can i ask", "what can i ask you about", "help", "topics" },
            "Great question! You can ask me about:\n" +
            "  • 🔑 Password safety\n" +
            "  • 🎣 Phishing scams\n" +
            "  • 🌐 Safe browsing\n" +
            "  • 🛡️ General cybersecurity tips\n" +
            "  • 🦠 Malware & viruses\n" +
            "  Type 'exit' to quit anytime."
        },
        {
            new[] { "password", "passwords", "strong password" },
            "Password Safety Tips:\n" +
            "  • Use at least 12 characters mixing letters, numbers & symbols.\n" +
            "  • Never reuse passwords across different sites.\n" +
            "  • Use a password manager to store them securely.\n" +
            "  • Enable two-factor authentication (2FA) wherever possible."
        },
        {
            new[] { "phishing", "phish", "scam email", "fake email" },
            "Phishing Awareness:\n" +
            "  • Phishing emails trick you into revealing personal info.\n" +
            "  • Always verify the sender's email address carefully.\n" +
            "  • Never click suspicious links — hover to preview the URL first.\n" +
            "  • Legitimate companies will NEVER ask for your password via email."
        },
        {
            new[] { "safe browsing", "browsing", "browse safely", "internet safety" },
            "Safe Browsing Tips:\n" +
            "  • Always look for HTTPS (🔒) in the URL bar.\n" +
            "  • Avoid downloading files from untrusted websites.\n" +
            "  • Use a reputable browser with privacy extensions.\n" +
            "  • Keep your browser and plugins up to date."
        },
        {
            new[] { "malware", "virus", "ransomware", "spyware" },
            "Malware Protection:\n" +
            "  • Install reputable antivirus software and keep it updated.\n" +
            "  • Don't open email attachments from unknown senders.\n" +
            "  • Backup your data regularly to defend against ransomware.\n" +
            "  • Avoid pirated software — it often contains hidden malware."
        },
        {
            new[] { "2fa", "two factor", "two-factor", "mfa" },
            "Two-Factor Authentication (2FA):\n" +
            "  • 2FA adds an extra layer of security beyond your password.\n" +
            "  • Even if your password is stolen, attackers can't log in without the second factor.\n" +
            "  • Use an authenticator app (e.g., Google Authenticator) rather than SMS when possible."
        },
    };

        public static string GetResponse(string input)
        {
            string lowerInput = input.ToLower().Trim();

            foreach (var pair in _responses)
            {
                foreach (var keyword in pair.Key)
                {
                    if (lowerInput.Contains(keyword))
                        return pair.Value;
                }
            }

            return "I didn't quite understand that. Could you rephrase? 🤔\n" +
                   "  Try asking about: passwords, phishing, safe browsing, malware, or type 'help'.";
        }
    }
}


