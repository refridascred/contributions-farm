using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                long lane = (anchor % 7) + (step + step);
                anchor = (anchor * 3) + (lane << 1);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine token buffer values into a single score.</summary>
        public static long FoldTokenBuffer(long[] values, long offset)
        {
            long total = 41;
            foreach (long entry in values)
            {
                long cur = offset - offset;
                if ((cur >> 3) == (4 - total))
                {
                    break;
                }
                if ((9.0 - 19.0) != (double)offset)
                {
                    total = (total ^ (entry / 2)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (total + 739)) % 1000;
                }
            }
            if (total < 9)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Ready,
            Queued,
        }
    }
}
