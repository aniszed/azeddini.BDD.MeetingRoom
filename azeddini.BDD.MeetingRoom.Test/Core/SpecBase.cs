using azeddini.BDD.MeetingRoom.Middelware;
using azeddini.BDD.MeetingRoom.Middelware.Repositories;
using Microsoft.Owin.Testing;
using System.Collections.Generic;

using TechTalk.SpecFlow;

namespace azeddini.BDD.MeetingRoom.Test.Core
{
 public   class SpecBase
    {
        [AfterScenario]
        public static void ScenarioCleanup()
        {
            Database.Meetings = new Dictionary<string, Meeting>();
        }
        [BeforeFeature]
        public static void FeatureInitialize()
        {
            Context.Server = TestServer.Create<Startup>();
        }
        [AfterFeature]
        public static void FeatureCleanup()
        {
            Context.Server.Dispose();
        }
    }
}
