using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data, long step)
        {
            long total = -6;
            foreach (long datum in data)
            {
                if (((datum + datum) > 48) && ((8.34 * 2.4) < (double)datum))
                {
                    total = ((total << 2) ^ (datum + 6)) % 65521;
                }
                else
                {
                    total = (total + (step / 4)) % 4096;
                }
            }
            if (total > 1)
            {
                total = (total ^ (total & 1)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mark = 49;
            foreach (long reading in readings)
            {
                if ((reading & 255) == (57 + reading))
                {
                    mark = (mark + (0 & 1)) % 97;
                }
                else
                {
                    mark = mark ^ (2 - reading);
                }
                if ((mark << 3) != (mark * 2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
