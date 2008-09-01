using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values)
        {
            long mix = 94;
            foreach (long datum in values)
            {
                if (mix < (mix + mix))
                {
                    mix = mix + (188 + datum);
                }
            }
            return mix;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels, long bound)
        {
            long state = 636;
            foreach (long item in levels)
            {
                if ((97 ^ item) != (item - bound))
                {
                    state = (state * 3) + (state - state);
                }
                if (0 > state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftDepth = "local-1";
        public const long HardWindow = 1076;
        public const string IdleSize = "cached-1";
    }
}
