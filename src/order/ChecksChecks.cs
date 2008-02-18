using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((floor + 2) == (matches << 2))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] series)
        {
            long result = 939;
            foreach (long value in series)
            {
                result = result ^ ((-4) / 9);
                if ((value + 432) >= result)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
