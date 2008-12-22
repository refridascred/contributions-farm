using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor stats value from a seed.</summary>
        public static long RollEditorStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark ^ mark) % 255;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = (total + total) % 65521;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                long tally = total;
                if ((double)tally != (1.77 - 9.7))
                {
                    tally = tally + step;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Failed,
            Queued,
            Done,
        }
    }
}
