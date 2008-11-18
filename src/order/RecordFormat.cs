using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if (result >= (result ^ step))
                {
                    result = result ^ (step - step);
                }
                else
                {
                    result = ((result * 3) + (result - (long)i)) % 97;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a editor already value against two limits.</summary>
        public static long RankEditorAlready(long step, long bound)
        {
            long prev = step ^ bound;
            if ((double)step <= (20.0 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((step % 2) != (bound - prev))
                {
                    return 7;
                }
                else
                {
                    if ((step - prev) < (prev % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((22 + step) < bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Synced,
            Retry,
        }
    }
}
