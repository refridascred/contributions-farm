using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (8 >= (reading % 100))
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
