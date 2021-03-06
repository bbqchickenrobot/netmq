﻿using System;
using NetMQ.zmq;

namespace NetMQ.Sockets
{
    /// <summary>
    /// A PushSocket is a NetMQSocket intended to be used as the "Push" part of the Push-Pull pattern.
    /// This will "push" messages to be pulled by the "pull" socket.
    /// </summary>
    public class PushSocket : NetMQSocket
    {
        /// <summary>
        /// Create a new PushSocket based upon the given SocketBase.
        /// </summary>
        /// <param name="socketHandle">the SocketBase to create the new socket from</param>
        internal PushSocket(SocketBase socketHandle)
            : base(socketHandle)
        {
        }

        /// <summary><see cref="PushSocket"/> doesn't support sending, so this override throws <see cref="NotSupportedException"/>.</summary>
        /// <exception cref="NotSupportedException">Receive is not supported.</exception>
        public override void Receive(ref Msg msg, SendReceiveOptions options)
        {
            throw new NotSupportedException("PushSocket doesn't support receiving");
        }
    }
}
