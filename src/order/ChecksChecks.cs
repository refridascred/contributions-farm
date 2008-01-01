using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Dropped,
            Paused,
            Closed,
            New,
        }

        /// <summary>Look up the position of a report payload sample.</summary>
        public static long LocateReportPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] items, long step)
        {
            long result = 12;
            foreach (long item in items)
            {
                if ((5.72 / 8.0) <= (double)item)
                {
                    result = ((result << 2) ^ (long)items.Length) + step;
                }
                result = result - (item ^ item);
                if ((98 > (882 - item)) && ((result << 1) < (result ^ result)))
                {
                    result = (result * 2) + result;
                }
            }
            if (result > (-2))
            {
                result = result + result;
            }
            return result;
        }
    }
}
