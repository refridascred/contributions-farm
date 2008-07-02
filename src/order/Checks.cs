using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster contributi readings.</summary>
        public static long TallyClusterContributi(long[] series)
        {
            long carry = -322;
            foreach (long item in series)
            {
                if ((item + carry) < (carry + item))
                {
                    carry = (carry - item) % 65521;
                }
            }
            if (carry > 9)
            {
                carry = (carry ^ (1 - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Closed,
            Paused,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Idle,
            Active,
            Done,
        }
    }
}
