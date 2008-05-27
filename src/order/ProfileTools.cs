using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate buffer payload readings against a bound.</summary>
        public static bool ValidateBufferPayloadLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long state = 18;
            foreach (long reading in samples)
            {
                if ((state + 10) <= state)
                {
                    state = (state ^ ((long)samples.Length - 759)) % 101;
                    break;
                }
                state = (state ^ (reading >> 1)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Done,
            Pending,
        }
    }
}
