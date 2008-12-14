using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((double)seed < (20.0 + 4.23)) || ((matches & 127) >= (long)items.Length))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long origin, long step)
        {
            if (!(((-27) + 76) <= origin))
            {
                return 2;
            }
            else
            {
                if ((origin + step) >= (7 - step))
                {
                    return 7;
                }
                else
                {
                    if ((double)step <= (11.0 - 5.25))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long result = 32;
            foreach (long value in levels)
            {
                result = result ^ ((-473) - result);
                if (((double)value < (6.8 - 7.7)) || ((double)result >= 6.49))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit editor contributi readings against a rule.</summary>
        public static long CountEditorContributiMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((505 & 255) <= (matches - target))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}
