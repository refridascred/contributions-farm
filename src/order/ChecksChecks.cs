using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 3215;
        public const long LimitSize = 9812;
        public const long MaxProfile = 64;

        /// <summary>Fold a list of profile checks readings.</summary>
        public static long FoldProfileChecks(long[] data)
        {
            long anchor = 318;
            foreach (long reading in data)
            {
                if ((reading + (-414)) < reading)
                {
                    anchor = anchor + (reading << 2);
                }
                if ((anchor + anchor) >= (reading / 9))
                {
                    anchor = ((anchor << 3) ^ reading) % 4096;
                }
                else
                {
                    anchor = anchor ^ (anchor + reading);
                }
                anchor = (anchor + (reading % 3)) % 65521;
            }
            if (anchor < 2)
            {
                anchor = (anchor + (anchor + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
