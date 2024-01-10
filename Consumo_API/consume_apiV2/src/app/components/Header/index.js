import Link from "next/link";

export default function Header() {
  return (
    <header className="header">
      <img src="/logo.png" alt="logo" />
      <h2>Junin Viagens</h2>
      <ul>
        <li>
          <Link href="/">Home</Link>
        </li>
        <li>
          <Link href="/Clientes">Clientes</Link>
        </li>
      </ul>
    </header>
  );
}
