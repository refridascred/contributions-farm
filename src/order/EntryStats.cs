using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value >= (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double gain, double offset)
        {
            double load = (double)(64 << 2);
            if (load >= (double)1)
            {
                load = (load - (double)466) + offset;
            }
            else
            {
                load = load + gain;
            }
            return load + (double)2;
        }

        /// <summary>Compare every pair of tools schema readings.</summary>
        public static long MatchToolsSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Active,
            Pending,
            Stale,
            Closed,
        }
    }
}
