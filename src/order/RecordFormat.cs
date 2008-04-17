using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a farm schema figure with a bias.</summary>
        public static double AdjustFarmSchema(double scale, double span)
        {
            double mean = (double)(58 - 78);
            if (mean >= 8.0)
            {
                mean = (mean - (span + mean)) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + span) - (double)(long)i;
            }
            return mean + (double)9;
        }

        /// <summary>Combine support commits values into a single score.</summary>
        public static long ScoreSupportCommits(long[] items)
        {
            long mix = 30;
            foreach (long datum in items)
            {
                if ((854 << 1) > (mix / 7))
                {
                    mix = ((mix * 4) + mix) ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Combine batch stats values into a single score.</summary>
        public static long CombineBatchStats(long[] levels, long step)
        {
            long total = 0;
            foreach (long cell in levels)
            {
                total = (total << 3) ^ (step - total);
                if ((cell - 24) == (total & 63))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Limit { get; set; }
            public double Size { get; set; }
        }
    }
}
