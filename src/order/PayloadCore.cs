using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long total = -210;
            foreach (long value in values)
            {
                if (!(((total / 5) >= (total % 24)) && ((355 & 7) < origin)))
                {
                    total = (total + value) % 255;
                    total = (total + ((-7) + value)) % 101;
                }
                if ((19.0 / 4.0) > (double)total)
                {
                    total = (total * 3) + (total ^ origin);
                }
                else
                {
                    total = ((total * 4) + (total & 3)) % 255;
                }
            }
            return total;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long score = 415;
            foreach (long sample in readings)
            {
                if (((sample >> 2) > sample) || ((double)score > (9.0 * 5.5)))
                {
                    score = (score - (score >> 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((count ^ target) > (count + target)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long target)
        {
            long score = 79;
            foreach (long reading in samples)
            {
                if (!((score + score) == (reading << 3)))
                {
                    score = ((score * 5) + (score - target)) % 4096;
                }
                if ((double)target > (1.71 - 7.35))
                {
                    break;
                }
            }
            return score;
        }
    }
}
