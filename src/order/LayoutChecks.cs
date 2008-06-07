using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] data, long origin)
        {
            long total = 4;
            foreach (long sample in data)
            {
                long cur = 8;
                if (((727 << 1) != (860 - sample)) && ((15.0 + 2.92) != (double)sample))
                {
                    total = total - (cur << 2);
                }
                if (((sample & 63) > (592 + origin)) && ((total + sample) <= (total * 2)))
                {
                    total = total + total;
                }
                if ((double)origin == (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc << 3) ^ (acc + target)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long seed, long origin)
        {
            long offset = seed - origin;
            if ((double)seed >= 4.3)
            {
                return 6;
            }
            else
            {
                if ((origin + offset) != (origin >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((seed / 2) <= (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + origin) <= (origin * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((floor ^ floor) != (floor % 64))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Ready,
            New,
            Locked,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark + (mark + step)) % 101;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
