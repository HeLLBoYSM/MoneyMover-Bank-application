* {
  margin: 0;
  padding: 0;
  box-sizing: inherit;
}

html {
  font-size: 62.5%;
  box-sizing: border-box;
}

body {
  font-family: 'Poppins', sans-serif;
  color: #444;
  background-color: #f3f3f3;
  height: 100vh;
  padding: 2rem;
}

nav {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 0 2rem;
}

.welcome {
  font-size: 1.9rem;
  font-weight: 500;
}

.logo {
  height: 5.25rem;
}

.login {
  display: flex;
}

.login__input {
  border: none;
  padding: 0.5rem 2rem;
  font-size: 1.6rem;
  font-family: inherit;
  text-align: center;
  width: 12rem;
  border-radius: 10rem;
  margin-right: 1rem;
  color: inherit;
  border: 1px solid #fff;
  transition: all 0.3s;
}

.login__input:focus {
  outline: none;
  border: 1px solid #ccc;
}

.login__input::placeholder {
  color: #bbb;
}

.login__btn {
  border: none;
  background: none;
  font-size: 2.2rem;
  color: inherit;
  cursor: pointer;
  transition: all 0.3s;
}

.login__btn:hover,
.login__btn:focus,
.btn--sort:hover,
.btn--sort:focus {
  outline: none;
  color: #777;
}

section {
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 1rem;
}
section input {
  padding: 0.5rem;
  border: none;
  border-radius: 0.5rem;
  font-weight: 700;
}
.info {
  display: flex;
  flex-direction: column;
  align-items: center;
  margin: 15rem 0 4rem 0;
}

/* MAIN */
.app {
  position: relative;
  max-width: 100rem;
  margin: 4rem auto;
  display: grid;
  grid-template-columns: 4fr 3fr;
  grid-template-rows: auto repeat(3, 15rem) auto;
  gap: 2rem;
  opacity: 0;
  transition: all 1s;
}

.balance {
  grid-column: 1 / span 2;
  display: flex;
  align-items: flex-end;
  justify-content: space-between;
  margin-bottom: 2rem;
}

.balance__label {
  font-size: 2.2rem;
  font-weight: 500;
  margin-bottom: -0.2rem;
}

.balance__date {
  font-size: 1.4rem;
  color: #888;
}

.balance__value {
  font-size: 4.5rem;
  font-weight: 400;
}

/* MOVEMENTS */
.movements {
  grid-row: 2 / span 3;
  background-color: #fff;
  border-radius: 1rem;
  overflow: scroll;
}

.movements__row {
  padding: 2.25rem 4rem;
  display: flex;
  align-items: center;
  border-bottom: 1px solid #eee;
}

.movements__type {
  font-size: 1.1rem;
  text-transform: uppercase;
  font-weight: 500;
  color: #fff;
  padding: 0.1rem 1rem;
  border-radius: 10rem;
  margin-right: 2rem;
}

.movements__date {
  font-size: 1.1rem;
  text-transform: uppercase;
  font-weight: 500;
  color: #666;
}

.movements__type--deposit {
  background-image: linear-gradient(to top left, #39b385, #9be15d);
}

.movements__type--withdrawal {
  background-image: linear-gradient(to top left, #e52a5a, #ff585f);
}

.movements__value {
  font-size: 1.7rem;
  margin-left: auto;
}

/* SUMMARY */
.summary {
  grid-row: 5 / 6;
  display: flex;
  align-items: baseline;
  padding: 0 0.3rem;
  margin-top: 1rem;
}

.summary__label {
  font-size: 1.2rem;
  font-weight: 500;
  text-transform: uppercase;
  margin-right: 0.8rem;
}

.summary__value {
  font-size: 2.2rem;
  margin-right: 2.5rem;
}

.summary__value--in,
.summary__value--interest {
  color: #66c873;
}

.summary__value--out {
  color: #f5465d;
}

.btn--sort {
  margin-left: auto;
  border: none;
  background: none;
  font-size: 1.3rem;
  font-weight: 500;
  cursor: pointer;
}

/* OPERATIONS */
.operation {
  border-radius: 1rem;
  padding: 3rem 4rem;
  color: #333;
}

.operation--transfer {
  background-image: linear-gradient(to right, #396cd1, #66b2ff);
}

.operation--loan {
  background-image: linear-gradient(to right, #00cc00, #ffff00);
}

.operation--close {
  background-image: linear-gradient(to right, #ff0000, #ff9900);
}

h2 {
  margin-bottom: 1.5rem;
  font-size: 1.7rem;
  font-weight: 600;
  color: #333;
}

.form {
  display: grid;
  grid-template-columns: 2.5fr 2.5fr 1fr;
  grid-template-rows: auto auto;
  gap: 0.4rem 1rem;
}

/* Exceptions for interst */
.form.form--loan {
  grid-template-columns: 2.5fr 1fr 2.5fr;
}
.form__label--loan {
  grid-row: 2;
}
/* End exceptions */

.form__input {
  width: 100%;
  border: none;
  background-color: rgba(255, 255, 255, 0.4);
  font-family: inherit;
  font-size: 1.5rem;
  text-align: center;
  color: #333;
  padding: 0.3rem 1rem;
  border-radius: 0.7rem;
  transition: all 0.3s;
}

.form__input:focus {
  outline: none;
  background-color: rgba(255, 255, 255, 0.6);
}

.form__label {
  font-size: 1.3rem;
  text-align: center;
}

.form__btn {
  border: none;
  border-radius: 0.7rem;
  font-size: 1.8rem;
  background-color: #fff;
  cursor: pointer;
  transition: all 0.3s;
}

.form__btn:focus {
  outline: none;
  background-color: rgba(255, 255, 255, 0.8);
}

