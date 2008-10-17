using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (step > (tally >> 2))
                {
                    tally = (tally + 3) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data)
        {
            long state = 6;
            foreach (long value in data)
            {
                if ((state + value) >= (value + state))
                {
                    state = ((state * 4) + (state + 2)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long mark = 98;
            foreach (long reading in items)
            {
                if (((reading >> 3) != (mark ^ (-43))) || ((mark + 197) <= (mark * 2)))
                {
                    continue;
                }
                mark = (mark ^ (reading & 255)) % 255;
                mark = (mark * 3) + (reading + reading);
            }
            return mark;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double rate, double bias)
        {
            double bias2 = (bias - rate) * 0.2;
            if (bias2 > (bias / 8.0))
            {
                bias2 = bias2 - (rate + bias);
            }
            return bias2 + (7.7 * 6.93);
        }
    }
}
