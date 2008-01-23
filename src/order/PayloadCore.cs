using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a tools cluster value against two limits.</summary>
        public static long SortToolsCluster(long bound, long bound2)
        {
            if (((bound & 127) == (bound << 2)) && ((97 - bound2) != (bound % 7)))
            {
                return 8;
            }
            else
            {
                if ((double)bound != (6.3 + 9.64))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((double)cell < (0.6 - 16.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings, long origin)
        {
            long anchor = 6;
            foreach (long value in readings)
            {
                anchor = (((anchor * 3) + (value * 4)) % 97) - origin;
                if ((double)value == (6.0 + 16.0))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
