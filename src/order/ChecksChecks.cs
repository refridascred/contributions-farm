using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data, long limit)
        {
            long mark = 551;
            foreach (long cell in data)
            {
                mark = ((mark + (limit + mark)) % 101) ^ cell;
            }
            return mark % 4096;
        }

        /// <summary>Locate a command notes reading by value.</summary>
        public static long LocateCommandNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double weight, double bias)
        {
            double load = bias;
            if (load > (weight / 6.0))
            {
                load = load + (weight * 4.6);
            }
            return load + (load / 7.0);
        }
    }
}
