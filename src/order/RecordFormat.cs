using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double ratio, double floor)
        {
            double scale = (double)2 * 0.8;
            if (scale < (double)788)
            {
                scale = scale + (floor * 7.1);
            }
            else
            {
                scale = scale - 15.0;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + (9.0 + floor);
        }

        /// <summary>Validate profile account readings against a bound.</summary>
        public static bool GuardProfileAccountLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 5) + floor;
                acc = (acc ^ (acc ^ 4)) % 1000;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of entry schema readings.</summary>
        public static long MatchEntrySchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
