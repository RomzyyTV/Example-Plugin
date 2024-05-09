using Exiled.API.Features;
namespace Example_Plugin
{
    public class EventHandlers : Plugin<Config>
    {

        public override void OnEnabled()
        {
            base.OnEnabled();
            Exiled.Events.Handlers.Server.RoundStarted += CassieMessage;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Exiled.Events.Handlers.Server.RoundStarted -= CassieMessage;
        }

        private void CassieMessage()
        {
            Cassie.MessageTranslated("", "", isHeld: false, isNoisy: false, isSubtitles: true); //Pour faire un message cassie debut de game
            Map.TurnOffAllLights(4); //Pour éteindre les lumiére pendant 4Seconde
        }
    }
}