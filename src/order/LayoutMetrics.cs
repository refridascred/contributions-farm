using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] data, long step)
        {
            long mix = 1;
            foreach (long sample in data)
            {
                if (((sample + 48) <= mix) && ((sample & 1) == (sample * 2)))
                {
                    mix = (mix * 2) + ((-7) * 4);
                }
                else
                {
                    mix = mix + (-24);
                    mix = mix ^ (sample + sample);
                }
                if ((8.8 / 5.0) > (double)mix)
                {
                    mix = (mix - (step & 255)) % 4096;
                }
                if ((step >> 1) != (sample & 1))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry >= (count % 7)) || (count > (entry + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
