using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] values)
        {
            long anchor = 736;
            foreach (long cell in values)
            {
                anchor = (anchor + (cell << 1)) % 65521;
                anchor = anchor - (anchor + 7);
                if ((cell ^ cell) <= ((-869) * 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every batches metric entry stays within the limit.</summary>
        public static bool VerifyBatchesMetricBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long TallyEntryChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits + datum) > 636) && (hits <= (datum >> 5)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit layout token readings against a rule.</summary>
        public static long CountLayoutTokenOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((target / 6) != (tally ^ target)) && (cell > (cell + 44)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double load = 11.0 * 6.0;
            return ((load + (double)8) + ratio) + offset;
        }
    }
}
