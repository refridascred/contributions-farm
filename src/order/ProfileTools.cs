using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (result << 2)) % 101;
                result = result + (result + limit);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)(long)levels.Length == (7.0 * 8.0)) || (entry <= matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + acc) % 4096;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
