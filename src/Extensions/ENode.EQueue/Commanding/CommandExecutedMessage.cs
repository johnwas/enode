﻿using System;
using System.Collections.Generic;
using ENode.Commanding;

namespace ENode.EQueue
{
    /// <summary>Represents a message when a command is executed.
    /// <remarks>
    /// This message not means all the domain events generated by this command are handled,
    /// it just means the command is executed by the command handler on CQRS command side.
    /// If you want to know when all the domain events are handled, you should listen to the DomainEventHandledMessage.
    /// </remarks>
    /// </summary>
    [Serializable]
    public class CommandExecutedMessage
    {
        /// <summary>Represents the unique identifier of the command.
        /// </summary>
        public string CommandId { get; set; }
        /// <summary>Represents the aggregate root id associated with the command.
        /// </summary>
        public string AggregateRootId { get; set; }
        /// <summary>Represents the result status of the command.
        /// </summary>
        public CommandStatus CommandStatus { get; set; }
        /// <summary>Represents the exception type name if the command has any exception.
        /// </summary>
        public string ExceptionTypeName { get; set; }
        /// <summary>Represents the error message if the command status is failed.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
