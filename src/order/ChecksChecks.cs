using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] readings)
        {
            long acc = 821;
            foreach (long cell in readings)
            {
                if ((double)acc >= 6.34)
                {
                    acc = (acc * 3) + cell;
                }
                acc = (acc + (cell & 127)) % 97;
            }
            return acc;
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
