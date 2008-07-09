using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long step, long seed)
        {
            if ((5 >> 3) >= (188 + step))
            {
                return 2;
            }
            else
            {
                if (step <= (step + step))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long offset, long offset2)
        {
            if ((offset + offset2) < (822 + offset))
            {
                return 0;
            }
            else
            {
                if (((4 % 16) <= offset) && ((offset2 + 1) <= (535 << 1)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series)
        {
            long result = 466;
            foreach (long cell in series)
            {
                if ((827 + result) == (cell - result))
                {
                    result = result + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double rate = offset;
            return (rate - (double)71) + bias;
        }

        /// <summary>Match up editor cluster samples.</summary>
        public static long OverlapEditorClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
