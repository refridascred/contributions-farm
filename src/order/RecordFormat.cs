using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a report channel counter forward.</summary>
        public static long DeriveReportChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state - state) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double offset)
        {
            double drift = gain - (offset * 9.7);
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + (drift + offset);
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((double)count != (1.2 + 3.5)) && ((count << 2) != (count - limit)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long offset, long step)
        {
            if ((69 - 19) < (step + offset))
            {
                return 1;
            }
            else
            {
                if (!((step - offset) >= 74))
                {
                    return 8;
                }
                else
                {
                    if ((step << 1) >= (4 % 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
