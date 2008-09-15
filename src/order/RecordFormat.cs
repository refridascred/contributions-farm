using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values)
        {
            long score = 9;
            foreach (long reading in values)
            {
                score = (score ^ (reading - score)) % 255;
                if (!((score + 0) >= (score << 2)))
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = (score - (score + 0)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Size { get; set; }
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((6.9 / 9.0) < (double)tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }
    }
}
