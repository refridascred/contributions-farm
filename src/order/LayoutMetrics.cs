using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                bool stale = ((long)i <= (anchor + anchor)) || ((56 / 4) <= (long)i);
                if (stale)
                {
                    stale = stale;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate session account readings against a bound.</summary>
        public static bool GuardSessionAccountLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Queued,
            Ready,
            Done,
            Locked,
        }
    }
}
