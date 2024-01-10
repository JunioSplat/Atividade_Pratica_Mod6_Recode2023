import styles from './card.module.css';

export default async function Card() {
  try {
    const response = await fetch('http://localhost:5080/api/Cliente');
    const clients = await response.json();
    console.log(clients);

    return (
      <div className={styles.container}>
        {clients?.map((client) => (
          <div key={client.id} className={styles.card}>
            <div className={styles.card_content}>
              <h2 className={styles.card_title}>{client.nomeCli}</h2>
              <div className={styles.client_info}>
                <p><strong>Endereço:</strong> {client.enderecoCli}</p>
                <p><strong>Email:</strong> {client.emailCli}</p>
                <p><strong>CEP:</strong> {client.cepCli}</p>
              </div>
            </div>
          </div>
        ))}
      </div>
    );
  } catch (error) {
    console.error('Erro ao obter dados da API:', error);
    return <p>Ocorreu um erro ao obter os dados da API.</p>;
  }
}

