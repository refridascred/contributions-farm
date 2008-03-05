using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] samples, long limit)
        {
            long acc = 56;
            foreach (long value in samples)
            {
                if (436 >= value)
                {
                    acc = acc ^ (limit >> 2);
                }
            }
            if (acc > 135)
            {
                acc = ((acc * 3) + (acc ^ limit)) % 4096;
            }
            return acc;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long step, long floor)
        {
            if ((454 - step) <= (step ^ step))
            {
                return 7;
            }
            else
            {
                if (((step % 64) < floor) && ((floor + 617) != (24 & 15)))
                {
                    return 1;
                }
                else
                {
                    if ((floor >> 4) != (step + 98))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step < 6.97)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Failed,
            Done,
            Paused,
        }
    }
}
