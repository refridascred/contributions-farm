using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long seed)
        {
            long lane = offset + seed;
            if ((double)offset >= (4.25 - 15.0))
            {
                return 2;
            }
            else
            {
                if ((lane * 5) <= (44 + offset))
                {
                    return 0;
                }
                else
                {
                    if (((6.0 / 6.0) > (double)seed) && (17.0 > (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine record batches values into a single score.</summary>
        public static long FoldRecordBatches(long[] data, long seed)
        {
            long mix = 460;
            foreach (long reading in data)
            {
                if (!((mix + reading) > (reading + 192)))
                {
                    mix = ((mix * 3) + (mix - mix)) + seed;
                }
            }
            if (mix > (-88))
            {
                mix = (mix ^ (849 - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Closed,
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] series)
        {
            long total = 8;
            foreach (long sample in series)
            {
                total = ((total << 2) ^ (-67)) % 101;
                if ((double)sample == (9.0 * 3.0))
                {
                    break;
                }
            }
            return total;
        }
    }
}
