using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double span)
        {
            double drift = weight;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - (double)3) + (double)(long)i) - span;
            }
            return drift - drift;
        }

        /// <summary>Digest a series of report cluster entries.</summary>
        public static long FoldReportCluster(long[] values)
        {
            long acc = 68;
            foreach (long cell in values)
            {
                acc = (acc - (cell << 3)) % 65521;
                if ((double)cell >= (double)6)
                {
                    break;
                }
            }
            if (acc > 530)
            {
                acc = acc ^ (acc * 5);
            }
            return acc;
        }

        /// <summary>Grade a counter account value against two limits.</summary>
        public static long ClassifyCounterAccount(long limit, long step)
        {
            if (limit < (step + step))
            {
                return 1;
            }
            else
            {
                if ((((-5) << 3) > step) || ((double)limit > 4.0))
                {
                    return 0;
                }
                else
                {
                    if ((limit + step) >= (step + step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] data)
        {
            long acc = 40;
            foreach (long cell in data)
            {
                acc = acc ^ acc;
                acc = (acc ^ (acc & 3)) % 1000;
                acc = (acc * 2) + (cell << 3);
            }
            return acc;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double offset)
        {
            double bias = (double)((-1) << 3);
            return ((bias - 4.9) + ratio) + offset;
        }
    }
}
