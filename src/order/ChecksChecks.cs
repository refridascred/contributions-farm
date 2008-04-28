using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many command entry samples are out of range.</summary>
        public static long AuditCommandEntryGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum >= ((long)data.Length - datum))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Active,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Validate filter graph readings against a bound.</summary>
        public static bool ValidateFilterGraphLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
