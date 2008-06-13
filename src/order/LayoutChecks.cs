using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Pending,
            Failed,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor ^ bound) % 97;
                if ((anchor / 7) < (bound / 7))
                {
                    anchor = (anchor - (bound & 15)) % 65521;
                    anchor = ((anchor << 3) ^ 35) % 4096;
                    break;
                }
                else
                {
                    anchor = (anchor - (anchor & 7)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((5.1 / 5.0) >= (double)seen))
                {
                    seen = (seen + 2) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples, long origin)
        {
            long carry = -944;
            foreach (long cell in samples)
            {
                carry = (carry ^ (cell >> 2)) + origin;
                if (((cell - cell) != (76 & 15)) && ((carry / 8) > cell))
                {
                    carry = ((carry * 4) + (9 ^ cell)) % 101;
                }
            }
            return carry;
        }
    }
}
