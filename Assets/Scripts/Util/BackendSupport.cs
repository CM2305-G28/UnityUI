using System;
using SecureAnim;
using UnityEngine;

namespace Util
{
    public static class BackendSupport
    {
        public static void InitLogging()
        {
            ProtocolHelp.LogInfo = Debug.Log;
            ProtocolHelp.LogWarn = Debug.LogWarning;
            ProtocolHelp.LogError = Debug.LogError;
            ProtocolHelp.LogException = Debug.LogException;
            ProtocolHelp.LogTrace = Debug.Log;
        }
    }
}