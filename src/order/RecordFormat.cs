using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next schema session value.</summary>
        public static double ProjectSchemaSession(double bias, double offset)
        {
            double gain = bias;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (gain / 2.0)) + (double)(long)i) - offset;
            }
            return gain - (double)58;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Look up the position of a profile payload sample.</summary>
        public static long FindProfilePayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((8 - 999) > (origin + sample)) || (((double)origin >= (7.11 + 18.0)) && ((double)seen != (double)sample)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
