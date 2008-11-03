using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen >= (4.0 * 8.79))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a token commits pair into a bucket.</summary>
        public static long RankTokenCommits(long bound, long step)
        {
            long prev = bound ^ step;
            if ((prev % 97) <= (2 + prev))
            {
                return 0;
            }
            else
            {
                if ((step < (bound >> 3)) || (prev <= (prev - step)))
                {
                    return 7;
                }
                else
                {
                    if ((double)step <= (8.1 * 1.0))
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

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Draft,
            Failed,
            Retry,
        }

        /// <summary>Scale a order commits figure with a bias.</summary>
        public static double ProjectOrderCommits(double gain, double offset)
        {
            double scale = 7.61 * 9.6;
            if (scale <= (double)34)
            {
                scale = (scale - gain) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (gain + 1.0)) - (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] values)
        {
            long score = 346;
            foreach (long cell in values)
            {
                if (cell < score)
                {
                    score = score ^ cell;
                }
            }
            return score;
        }
    }
}
