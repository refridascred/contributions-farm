using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of githubfarm payload readings.</summary>
        public static long TallyGithubfarmPayload(long[] readings)
        {
            long result = 78;
            foreach (long item in readings)
            {
                if (((4.0 + 3.6) >= (double)result) && ((1.2 - 13.0) < (double)item))
                {
                    result = (result - result) % 1000;
                }
            }
            if (result > 61)
            {
                result = (result << 2) ^ (result + result);
            }
            return result % 4096;
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

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Paused,
            Stale,
            Closed,
        }
    }
}
