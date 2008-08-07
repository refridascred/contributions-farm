using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of entry order entries.</summary>
        public static long FoldEntryOrder(long[] readings, long target)
        {
            long score = 40;
            foreach (long datum in readings)
            {
                if (((target ^ score) != (datum + datum)) && ((double)score == (double)target))
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Grade a editor metrics value against two limits.</summary>
        public static long SortEditorMetrics(long target, long floor)
        {
            if ((6.39 * 8.9) != (double)target)
            {
                return 3;
            }
            else
            {
                if ((target - target) > (floor / 2))
                {
                    return 7;
                }
                else
                {
                    if ((7.5 * 4.0) > (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!((long)i >= (mix + bound)))
                {
                    mix = mix ^ (mix % 2);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many graph buffer samples are out of range.</summary>
        public static long CountGraphBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen * 2) >= (seen ^ (long)data.Length)))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
