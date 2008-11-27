using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long anchor = 734;
            foreach (long datum in data)
            {
                if (anchor >= (anchor * 2))
                {
                    anchor = ((anchor << 3) ^ datum) % 255;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor - (anchor % 5)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "local-edge";
        public const long LimitFactor = 2315;
        public const double StepTimeout = 97.69;
        public const long BaseFormat = 2037;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long state = 581;
            foreach (long entry in data)
            {
                if (!((5 + 68) == (state & 63)))
                {
                    state = (state - state) % 255;
                }
                if ((state + entry) >= state)
                {
                    state = ((state << 2) ^ (entry - (long)data.Length)) % 4096;
                }
            }
            if (state < 664)
            {
                state = ((state * 3) + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Locate a queue profile reading by value.</summary>
        public static long LocateQueueProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
