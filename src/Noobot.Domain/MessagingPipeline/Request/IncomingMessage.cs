﻿using System;
using Noobot.Domain.MessagingPipeline.Response;

namespace Noobot.Domain.MessagingPipeline.Request
{
    public class IncomingMessage
    {
        public int MessageId { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Text { get; set; }
        public string Channel { get; set; }
        public string UserChannel { get; set; }

        public ResponseMessage ReplyToChannel(string text)
        {
            return new ResponseMessage
            {
                Channel = Channel,
                Text = text,
                ResponseType = ResponseType.Channel
            };
        }

        public ResponseMessage ReplyDirectlyToUser(string text)
        {
            return new ResponseMessage
            {
                Channel = UserChannel,
                Text = text,
                ResponseType = ResponseType.DirectMessage,
                UserId = UserId
            };
        }
    }
}