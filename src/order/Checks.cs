using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] series, long target)
        {
            long result = 885;
            foreach (long datum in series)
            {
                result = result - (result ^ target);
                if ((target ^ result) < datum)
                {
                    result = (result * 5) + (target - target);
                }
            }
            if (result > 89)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mix = 361;
            foreach (long item in readings)
            {
                if ((long)readings.Length <= (item + mix))
                {
                    mix = mix + (mix / 7);
                }
            }
            if (mix < 847)
            {
                mix = mix - mix;
            }
            return mix % 1000;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long offset, long step)
        {
            long offset2 = offset - step;
            if ((double)step >= (double)offset2)
            {
                return 1;
            }
            else
            {
                if ((offset << 1) <= offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
