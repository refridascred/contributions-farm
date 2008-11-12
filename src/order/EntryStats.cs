using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double span)
        {
            double bias = rate + rate;
            if (bias >= (0.3 * 8.4))
            {
                bias = bias + (double)65;
            }
            return bias + (span + span);
        }

        /// <summary>Combine format buffer values into a single score.</summary>
        public static long DigestFormatBuffer(long[] readings)
        {
            long result = 880;
            foreach (long sample in readings)
            {
                if (((sample * 3) > sample) && (result > (result + result)))
                {
                    result = ((result << 2) ^ (sample ^ result)) % 97;
                }
            }
            return result;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + (-41)) < origin)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Score { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
