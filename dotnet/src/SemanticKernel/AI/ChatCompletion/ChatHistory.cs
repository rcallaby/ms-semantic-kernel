﻿// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;

namespace Microsoft.SemanticKernel.AI.ChatCompletion;

public class ChatHistory
{
    /// <summary>
    /// Chat message representation
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Role of the message author, e.g. user/assistant/system
        /// </summary>
        public string AuthorRole { get; set; }

        /// <summary>
        /// Message content
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="authorRole">Role of message author</param>
        /// <param name="content">Message content</param>
        public Message(string authorRole, string content)
        {
            this.AuthorRole = authorRole;
            this.Content = content;
        }
    }

    /// <summary>
    /// List of messages in the chat
    /// </summary>
    public List<Message> Messages { get; }

    /// <summary>
    /// Create a new instance of the chat content class
    /// </summary>
    public ChatHistory()
    {
        this.Messages = new List<Message>();
    }

    /// <summary>
    /// Add a message to the chat history
    /// </summary>
    /// <param name="authorRole">Role of the message author</param>
    /// <param name="content">Message content</param>
    public void AddMessage(string authorRole, string content)
    {
        this.Messages.Add(new Message(authorRole, content));
    }
}
