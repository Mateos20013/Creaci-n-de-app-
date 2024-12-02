namespace Notes.Models;

internal class About
{
    public string Title => "Mateo Sotomayor";
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "Hola mi nombre es Mateo Sotomayor, soy un estudiante de Ingeniería de Software apasionado por los drones. Me encanta la emoción de las competencias y siempre intento buscar nuevas formas de mejorar mis habilidades y compartir con gente.";
    public string Icon { get; set; }
}