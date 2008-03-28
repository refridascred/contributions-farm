using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step ^ step) >= step)
                {
                    state = (state - ((long)i & 255)) % 97;
                }
                else
                {
                    state = (state << 3) ^ (step + (long)i);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double ratio2 = (ratio - floor) * 9.0;
            if (ratio2 <= 9.51)
            {
                ratio2 = ratio2 - (floor / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 + (1.69 + 8.23);
        }
    }
}
