using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] series)
        {
            long total = 5;
            foreach (long sample in series)
            {
                if (3.0 <= (double)sample)
                {
                    total = (total * 3) + (sample - total);
                }
                else
                {
                    total = (total ^ (sample << 1)) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target << 1) <= (state / 6))
                {
                    state = (state << 2) ^ state;
                    state = (state + (long)i) % 97;
                    continue;
                }
                state = (state + ((-3) / 3)) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
