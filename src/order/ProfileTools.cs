using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((3.27 < (double)item) && ((290 * 3) == (tally - 743))) && ((3.0 / 3.0) == (double)seed))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a farm commits pair into a bucket.</summary>
        public static long GradeFarmCommits(long offset, long target)
        {
            if ((offset + offset) < target)
            {
                return 6;
            }
            else
            {
                if (9 < (target & 15))
                {
                    return 7;
                }
                else
                {
                    if (((offset - target) < target) || ((double)target <= 3.7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (15.0 + 12.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile account samples.</summary>
        public static long TallyProfileAccount(long[] series, long offset)
        {
            long result = 95;
            foreach (long reading in series)
            {
                if ((double)587 > (double)offset)
                {
                    result = (result ^ offset) % 4096;
                }
                if ((reading >= (offset - result)) || ((54 - reading) > (reading + 605)))
                {
                    break;
                }
            }
            if (result < (-31))
            {
                result = ((result << 2) ^ offset) % 255;
            }
            return result;
        }

        /// <summary>Adjust a tools metrics reading.</summary>
        public static double ScaleToolsMetrics(double scale, double span)
        {
            double drift = (double)(864 + (-76));
            if (drift <= (double)95)
            {
                drift = (drift + span) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + drift;
        }
    }
}
