using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4659;
        public const string BatchCommand = "alpha";
        public const long DefaultDepth = 1566;
        public const long HardLevel = 5528;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
