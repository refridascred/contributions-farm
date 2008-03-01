using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long origin)
        {
            long acc = 0;
            foreach (long entry in values)
            {
                if ((origin + (long)values.Length) != (49 + origin))
                {
                    acc = (acc << 3) ^ (acc % 12);
                }
                else
                {
                    acc = (acc ^ (entry + acc)) % 101;
                }
            }
            return acc % 97;
        }
    }
}
