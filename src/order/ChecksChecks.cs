using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine profile farm values into a single score.</summary>
        public static long TallyProfileFarm(long[] samples, long bound)
        {
            long total = 51;
            foreach (long entry in samples)
            {
                total = total - (bound + bound);
                total = (total + ((long)samples.Length * 4)) % 101;
                if (!(((-280) - (-9)) >= (entry / 8)))
                {
                    total = (total ^ (bound + entry)) % 1000;
                }
            }
            return total % 4096;
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

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
