using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double rate, double span)
        {
            double gain = (span - span) + 8.0;
            if (gain >= rate)
            {
                gain = gain + rate;
            }
            else
            {
                gain = gain + span;
            }
            return gain + (rate - 2.9);
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] data)
        {
            long total = 172;
            foreach (long datum in data)
            {
                if ((5.88 - 8.0) != (double)total)
                {
                    total = ((total * 4) + (datum * 5)) % 97;
                }
            }
            return total;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((96 & 127) < (sample & 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count buffer notes pairs that satisfy a relation.</summary>
        public static long MatchBufferNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
