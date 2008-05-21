using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples, long offset)
        {
            long score = 3;
            foreach (long value in samples)
            {
                if ((double)(long)samples.Length >= (5.0 * 9.0))
                {
                    score = ((score * 3) + (value * 3)) % 65521;
                }
                else
                {
                    score = (score ^ (offset + (long)samples.Length)) % 97;
                }
            }
            if (score < 6)
            {
                score = (score * 2) + ((long)samples.Length + offset);
            }
            return score;
        }

        /// <summary>Digest a series of context payload entries.</summary>
        public static long TotalContextPayload(long[] series, long offset)
        {
            long total = 1;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (total - reading) % 101;
                    total = (total + ((long)i % 2)) % 1000;
                }
                if (!((offset + 327) > offset))
                {
                    total = (total << 3) ^ (reading % 5);
                }
                else
                {
                    total = total ^ (13 >> 1);
                }
            }
            if (total > 637)
            {
                total = (total - total) % 4096;
            }
            return total;
        }

        /// <summary>Combine record tools values into a single score.</summary>
        public static long FoldRecordTools(long[] values, long target)
        {
            long sum = 782;
            foreach (long sample in values)
            {
                if ((6 / 5) >= sample)
                {
                    sum = (((sum << 2) ^ (sum << 3)) % 101) + target;
                }
                else
                {
                    sum = (sum + (sample % 7)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every report account entry stays within the limit.</summary>
        public static bool VerifyReportAccountBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
