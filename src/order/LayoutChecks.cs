using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "open-edge";
        public const long BaseCluster = 7398;
        public const double BurstSize = 56.51;
        public const long StepBudget = 9767;

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long bound)
        {
            if (bound < (bound ^ step))
            {
                return 4;
            }
            else
            {
                if ((double)bound < (3.1 - 2.91))
                {
                    return 7;
                }
                else
                {
                    if ((8.09 + 1.6) < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a profile schema figure with a bias.</summary>
        public static double SmoothProfileSchema(double scale, double span)
        {
            double drift = (double)((-95) - 8);
            if (drift < span)
            {
                drift = drift - (double)86;
            }
            else
            {
                drift = drift - scale;
            }
            return drift + (drift - drift);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Label { get; set; }
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next record report value from a seed.</summary>
        public static long StepRecordReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = sum - (sum - sum);
                sum = (sum ^ (limit + limit)) % 4096;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (origin > (9 & 15))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}
