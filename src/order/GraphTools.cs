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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum + sum) % 4096) + (long)i2;
                    sum = sum + (target + sum);
                }
                if (((sum % 100) <= target) && ((342 ^ target) > (926 - target)))
                {
                    sum = sum + ((long)i / 5);
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
